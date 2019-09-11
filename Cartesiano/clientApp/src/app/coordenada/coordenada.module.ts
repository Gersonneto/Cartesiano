import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {  ReactiveFormsModule } from '@angular/forms';

import { RotaComponent } from './rota/rota.component';
import { RotaService } from './rota.service';
import { HttpModule } from '@angular/http';




@NgModule({
  declarations: [
    RotaComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpModule
    
  ],
  exports: [
    RotaComponent
  ],
  providers: [
    
  ]
})
export class CoordenadaModule { }
