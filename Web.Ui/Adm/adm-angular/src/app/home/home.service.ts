import { Injectable } from '@angular/core';

@Injectable()
export class HomeService {

  constructor() { }

  getEspecialidade(){
    return ['Sombrancelhas', 'estética', 'Cabelereiro'];
  }
}
