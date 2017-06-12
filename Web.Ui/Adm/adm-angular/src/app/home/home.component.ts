import { Component, OnInit, Input, ViewContainerRef  } from '@angular/core';
import { HomeService } from "app/service/home.service";
import { Home } from "app/model/home.model";
import { ToastsManager } from 'ng2-toastr/ng2-toastr';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  modelo : Home;
  homeSrv: HomeService;
    

  listaValores : any;
  @Input() testeInput : string;
  constructor(homeService: HomeService, public toastr: ToastsManager, vcr: ViewContainerRef) {
    //this.especialidades = homeService.getEspecialidade();
      this.toastr.setRootViewContainerRef(vcr);
      this.modelo = new Home();
      this.homeSrv = homeService;
      this.ListaValores();

      
   }

   public cadastrar(){
       this.homeSrv.CadastrarInfo(this.modelo);
       this.ListaValores();
       this.showSuccess();
   }

   public DeletarHome(id) {
       this.homeSrv.DeletarHome(id);
       this.ListaValores();
   }

   public ListaValores() {
       this.listaValores = this.homeSrv.GetInfo();
       this.showSuccess();
   }

   showSuccess() {
       this.toastr.success('Cadastrado com sucesso', 'Successo!', { 'position-class': 'toast-top-full-width'});
   }

  ngOnInit() {
  }

}
