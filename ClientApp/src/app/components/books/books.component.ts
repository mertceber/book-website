import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { BookService } from "src/app/services/book.service";

@Component({
  selector: "app-books",
  templateUrl: "./books.component.html",
  styleUrls: ["./books.component.css"]
})
export class BooksComponent implements OnInit {

  public books: Book[];
  constructor(private service: BookService, private router: Router) { }

  ngOnInit() {
    this.service.getAllBooks().subscribe(data => {
      this.books = data;
    });
  }

  showBook(id: number) {
    this.router.navigate(["/show-book/" + id]);
  }

  updateBook(id: number) {
    this.router.navigate(["/update-book/" + id]);
  }

  deleteBook(id: number) {
    this.router.navigate(["/delete-book/" + id]);
  }
}