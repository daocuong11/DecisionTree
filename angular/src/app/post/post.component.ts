import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateUpdatePostDto, PostDto } from '@proxy/contracts/dtos/post';
import { postCategoryOptions, PostService } from '@proxy/posts';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss'],
  providers: [ListService]
})
export class PostComponent {
  posts = { items: [], totalCount: 0 } as PagedResultDto<PostDto>;
  form: FormGroup;

  constructor(public readonly list: ListService, private postService: PostService, private fb: FormBuilder) { }

  editId = '';
  isModalOpen = false;
  categories = postCategoryOptions;

  text1 = `
  <h2>What is Lorem Ipsum?</h2>
  <p><strong>Lorem Ipsum</strong> is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>`;

  ngOnInit() {
    const bookStreamCreator = (query) => this.postService.getList(query);

    this.list.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.posts = response;
    });

  }

  createPost() {
    let item: CreateUpdatePostDto;
    this.buildForm(item); // add this line
    this.isModalOpen = true;
    this.editId = '';
  }

  editPost(item: PostDto) {
    this.editId = item.id;
    this.buildForm(item as CreateUpdatePostDto);
    this.isModalOpen = true;
  }

  buildForm(item: CreateUpdatePostDto) {
    this.form = this.fb.group({
      title: [item.title, [Validators.required, Validators.maxLength(255)]],
      category: [item.category, Validators.required],
      content: [item.content, Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    let model = this.form.value;

    if (this.editId) {
      this.postService.update(this.editId, model).subscribe(() => {
        this.isModalOpen = false;
        this.form.reset();
        this.list.get();
      });
    } else {
      this.postService.create(model).subscribe(() => {
        this.isModalOpen = false;
        this.form.reset();
        this.list.get();
      });
    }
  }

}
