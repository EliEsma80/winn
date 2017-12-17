import { Component } from '@angular/core';
import {PostsService} from '../services/posts.service';
import { Product } from './Product';

@Component({
  selector: 'user',
  templateUrl: 'app/components/user.component.html',
 
  providers:[PostsService] 
})
export class UserComponent  { 
  
     Attlist:boolean;
    
     MinPrice:number;
     MaxPrice:number;
     MinRate:number;
     MaxRate:number;
     products:Product[];
     
   
constructor(private postsService:PostsService) {
    
}

ngOnInit() {
    this.getProduct();
       
  }  


getProduct(){
         this.postsService.getProducts().subscribe(products => this.products = products)
         this.Attlist=null;};

filter(){
         this.postsService.getFilter(this.MinPrice, this.MaxPrice,this.MinRate, this.MaxRate).subscribe(products => this.products = products)
         this.Attlist=null;};

attfilter(){
         this.postsService.getAttFilter(this.Attlist).subscribe(products => this.products = products)
         this.MinPrice=null;
         this.MaxPrice=null;
         this.MinRate=null;
         this.MaxRate=null; };

}



