import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { EditorImagemComponent } from './editor-imagem/editor-imagem.component';
import { HomeModule } from "app/home/home.module";
import { HomeService } from "app/service/home.service";
import { ToastModule } from 'ng2-toastr/ng2-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
      BrowserModule,
      FormsModule,
      HttpModule,
      HomeModule,
      BrowserAnimationsModule,
      ToastModule.forRoot()
  ],
  providers: [
    HomeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
    

 }
