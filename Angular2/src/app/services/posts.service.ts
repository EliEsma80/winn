import {Injectable} from '@angular/core';
import { Observable }        from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { Product } from '../components/Product';


import { Http, Response }          from '@angular/http';
import { Headers, RequestOptions } from '@angular/http';

@Injectable()
export class PostsService {
constructor(private http:Http) {

}


getProducts(): Observable<Product[]>{
      return this.http.get('http://localhost:55215/api/products')
               .map(result => result.json());
}

getFilter(p1:number,p2:number,R1:number,R2:number): Observable<Product[]>{
      p1= p1==0?0:p1;
      p2= p2==0?0:p2;
      R1= R1==0?0:R1;
      R2= R2==0?0:R2;
      return this.http.get('http://localhost:55215/api/products/filter/' + p1 + '/' + p2 + '/' + R1 + '/' + R2)
               .map(result => result.json());           
}

getAttFilter(bool1:boolean): Observable<Product[]>{
     
      return this.http.get('http://localhost:55215/api/products/attfilter/' + bool1)
               .map(result => result.json());           
}


}
