import { Component, OnInit } from "@angular/core";
import { BookService } from "src/app/services/book.service";
import { ActivatedRoute, Router } from "@angular/router";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Component({
  selector: "app-update-book",
  templateUrl: "./update-book.component.html",
  styleUrls: ["./update-book.component.css"]
})
export class UpdateBookComponent implements OnInit {
  updateBookForm: FormGroup;
  book: any;

  constructor(
    private service: BookService,
    private route: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder
  ) { }

  ngOnInit() {
    this.updateBookForm = this.fb.group({
      id: [''],
      title: ['', Validators.required],
      author: ['', Validators.required],
      description: ['', Validators.compose([Validators.required, Validators.minLength(30)])],
      rate: [''],
      dateStart: [''],
      dateRead: [''],
    });

    this.service.getBookById(this.route.snapshot.params.id).subscribe(data => {
      this.book = data;
      this.updateBookForm.patchValue({
        id: data.id,
        title: data.title,
        author: data.author,
        description: data.description,
        rate: data.rate,
        dateStart: this.formatDate(data.dateStart),
        dateRead: this.formatDate(data.dateRead),
      });
    });
  }

  formatDate(date: Date) {
    if (date) {
      return new Date(date).toISOString().substring(0, 10);
    }
  }
  onSubmit() {
    this.service.updateBook(this.updateBookForm.value).subscribe(data => {
      this.router.navigate(["/books"]);
    });
  }
}