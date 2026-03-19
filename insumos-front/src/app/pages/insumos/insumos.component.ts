import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { InsumoService } from '../../services/insumo.service';
import { Insumo } from '../../models/insumo';

@Component({
  selector: 'app-insumos',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './insumos.component.html',
  styleUrls: ['./insumos.component.css']
})
export class InsumosComponent implements OnInit {

  insumos: Insumo[] = [];

  novoInsumo: Insumo = {
    id: 0,
    nome: '',
    unidadeMedida: '',
    custo: 0
  };

  loading: boolean = false;
  mensagemSucesso: string = '';
  mensagemErro: string = '';

  constructor(private insumoService: InsumoService) {}

  ngOnInit(): void {
    this.carregarInsumos();
  }

  carregarInsumos() {
    this.loading = true;
    this.insumoService.getInsumos().subscribe({
      next: (data) => {
        this.insumos = data;
        this.loading = false;
      },
      error: () => {
        this.mensagemErro = 'Erro ao carregar insumos';
        this.loading = false;
      }
    });
  }

  adicionar() {
    this.mensagemSucesso = '';
    this.mensagemErro = '';

    if (!this.novoInsumo.nome || !this.novoInsumo.unidadeMedida || this.novoInsumo.custo <= 0) {
      this.mensagemErro = 'Preencha todos os campos corretamente';
      return;
    }

    this.loading = true;
    this.insumoService.addInsumo(this.novoInsumo).subscribe({
      next: () => {
        this.carregarInsumos();
        this.novoInsumo = { id: 0, nome: '', unidadeMedida: '', custo: 0 };
        this.mensagemSucesso = 'Insumo cadastrado com sucesso ✅';
        this.loading = false;
      },
      error: () => {
        this.mensagemErro = 'Erro ao cadastrar insumo';
        this.loading = false;
      }
    });
  }

  deletar(id: number) {
  if (!confirm('Tem certeza que deseja excluir?')) return;

  this.loading = true;
  this.insumoService.deleteInsumo(id).subscribe({
    next: () => {
      this.carregarInsumos();
      this.mensagemSucesso = 'Insumo excluído com sucesso';
      this.loading = false;
    },
    error: () => {
      this.loading = false;
      this.mensagemErro = 'Erro ao excluir insumo';
    }
  });
}

} 
