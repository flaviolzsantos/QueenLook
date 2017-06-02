import { Component, OnInit, Input } from '@angular/core';
import { HomeService } from "app/home/home.service";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  especialidades : string[];
  @Input() testeInput : string;
  constructor(homeService : HomeService) {

    this.especialidades = homeService.getEspecialidade();
   }

  ngOnInit() {
  }

}
