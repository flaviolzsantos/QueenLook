import { Injectable } from '@angular/core';
import { Home } from "app/model/home.model";
import { Http, Headers, RequestOptions } from "@angular/http";
import * as $ from 'jquery';
import { HttpInterceptor } from "app/HttpInterceptor";

@Injectable()
export class HomeService {

    
    
    constructor(public http: HttpInterceptor) {
    
    }

    getEspecialidade(){
        return ['Sombrancelhas', 'estética', 'Cabelereiro'];        
    }

    
    CadastrarInfo(modelo: Home) {
        return this.http.post("Areas/Admin/Home/CadastrarHome", modelo);
    }

    GetInfo() {
        return this.http.get('Areas/Admin/Home/ObterListaHome');       
    }

    DeletarHome(id) {        
        return this.http.post('/Areas/Admin/Home/Deletar', { "" : id });
    }

    AtivarOuDeletar(id) {
        return this.http.post('/Areas/Admin/Home/AtivarOuDesativar', { "": id });
    }

}
