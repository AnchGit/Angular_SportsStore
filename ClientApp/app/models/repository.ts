import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs/Observable";

const productsUrl = "/api/products";

@Injectable()
export class Repository {

    private productData: Product;

    constructor(private httpClient: HttpClient) {
        this.getProduct(2);
    }

    getProduct(id: number) {
        this.sendRequest("GET", productsUrl + "/" + id)
            .subscribe(response => { this.productData = response; });
    }
    private sendRequest(verb: string, url: string,
        data?: any): Observable<any> {
        return this.httpClient.request(verb, url, data);
    }

    get product(): Product {
        console.log("Product Data Requested");
        return this.productData;
    }
}