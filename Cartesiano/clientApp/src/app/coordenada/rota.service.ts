import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { map } from 'rxjs/operators';

import { Icoordenadas } from '../Model/coordenada.interface';


@Injectable({
  providedIn: 'root'
})
export class RotaService {

  constructor(private http: Http) { }

  executa(coordenada: Icoordenadas) {
    return this.http.post("api/Cartesiano", coordenada)
      .pipe(map(response => response));
  }
}
