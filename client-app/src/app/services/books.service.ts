import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BooksDetailVM } from '../models/book.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BooksService {
  private apiUrl = '/api/books';

  constructor(private http: HttpClient) { }

  createBook(book: BooksDetailVM): Observable<any> {
    return this.http.post(this.apiUrl, book);
  }
}
