import { Injectable } from '@angular/core';
import { Home } from "app/model/home.model";
import { Http, Headers, RequestOptions } from "@angular/http";
import * as $ from 'jquery';

@Injectable()
export class HomeService {
  
    constructor(private http : Http) {
    
    }

    getEspecialidade(){
      return ['Sombrancelhas', 'estética', 'Cabelereiro'];
    }

    CadastrarInfo(modelo : Home){
    
        $.ajax(
        {
            type: "POST",
            url: "http://localhost:1234/Areas/Admin/Home/CadastrarHome",
            data: modelo,
            dataType: "json",
            async: false
        });    
    }

    GetInfo() {

        var retorno = $.ajax(
            {
                type: "GET",
                url: "http://localhost:1234/Areas/Admin/Home/ObterListaHome",
                dataType: "json",
                async: false
            });
        return retorno.responseJSON;
    }

    DeletarHome(id) {
        $.ajax(
            {
                type: "POST",
                url: "http://localhost:1234/Areas/Admin/Home/Deletar",
                data: { "": id },
                dataType: "json",
                async: false
            }); 
    }

}
