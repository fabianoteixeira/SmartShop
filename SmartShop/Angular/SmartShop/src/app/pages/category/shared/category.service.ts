import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from './category-model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  apiPath: string = 'http://localhost:52670/api/Category';

  constructor(private http: HttpClient) { }

  getAll(): Observable<Category[]>{
    return this.http.get(this.apiPath)
    .pipe(map(
      (resposta: Category[]) => {
          return resposta;
      }
      
  ))
    
  }

  private fromJson(jsonData: any): Category{
    return Object.assign(new Category(), jsonData);
}
}

