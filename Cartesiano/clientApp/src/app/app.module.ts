import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoordenadaModule } from './coordenada/coordenada.module';
import { RotaService } from './coordenada/rota.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CoordenadaModule,
    FormsModule,
    ReactiveFormsModule

  ],
  providers: [RotaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
