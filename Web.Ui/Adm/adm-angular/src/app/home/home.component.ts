import { Component, OnInit } from '@angular/core';
import { HomeService } from "app/home/home.service";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  especialidades : string[];
  constructor(homeService : HomeService) {

    this.especialidades = homeService.getEspecialidade();
   }

  ngOnInit() {
  }

}
