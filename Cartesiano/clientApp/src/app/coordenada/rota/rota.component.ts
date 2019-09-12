import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { RotaService } from '../rota.service';
import { Icoordenadas } from 'src/app/Model/coordenada.interface';
import { BOOL_TYPE } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-rota',
  templateUrl: './rota.component.html',
  styleUrls: ['./rota.component.css']
})
export class RotaComponent implements OnInit {
  form: FormGroup;

  coordenada: Icoordenadas = <Icoordenadas>{};
  retorno: string;

  constructor(private servico: RotaService, private fb: FormBuilder) {
    this.form = fb.group({
      "coordenadaInicial": ["", Validators.required],
      "movimentacoesCoordenadas": ["", Validators.required]
    });
  }

  ngOnInit() {
  }
    isCoordenadaValida(coordenada:string)
  {

        return (coordenada.split(",").length ==2) && !isNaN(Number(coordenada.split(",")[0])) && !isNaN(Number(coordenada.split(",")[1]));

  }
  
    isVetorDirecaoIntensidadeValida(dimensaoIntensiadade: string)
    {

 
    let vetorDimensaoIntensiadade: string[] = dimensaoIntensiadade.split(";");
    let tamanho: number = vetorDimensaoIntensiadade.length;
    let i: number = 0;
    let quantidadeConformidade: number = 0;

      while (i < tamanho )
      {
        
        let dimensao: string[] = vetorDimensaoIntensiadade[i].split(",");

        if (!isNaN(Number(dimensao[1])) && (isNaN(Number(dimensao[0])) && dimensao[0].length == 1))
        {
          if (dimensao[0].toUpperCase().search("[NSLO]") != -1)
           {
            quantidadeConformidade++;
           }
        }
        i++;
      }
      return (quantidadeConformidade == tamanho);
    }

  onSubmit() {
   this.retorno = "As coordenadas iniciais ou valores não esão no padrão. "
   this.retorno += " Favor Preencher dois números separados por virgula conforme exemplo Ex. 1,1. ";

    if (this.isCoordenadaValida(this.form.controls["coordenadaInicial"].value))
    {
      this.retorno = "As dimensões estão fora dos padrões  ou valores estão incoerentes ";
      this.retorno += " Favor Preencher a direção e a intensidade separados por virgula e  ";
      this.retorno += " os pares por ponto e virgula como exemplo N,12;O,10 . ";

      if (this.isVetorDirecaoIntensidadeValida(this.form.controls["movimentacoesCoordenadas"].value))
      { 
          this.coordenada.coordenadaInicial = this.form.controls["coordenadaInicial"].value;
          this.coordenada.movimentacoesCoordenadas = this.form.controls["movimentacoesCoordenadas"].value;

         this.servico.executa(this.coordenada)
          .subscribe(data => this.retorno = data.text(),
              erro => console.log(erro));
      }
    }
   
  }

}
