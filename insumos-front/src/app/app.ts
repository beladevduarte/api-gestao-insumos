import { Component } from '@angular/core';
import { InsumosComponent } from './pages/insumos/insumos.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [InsumosComponent],
  templateUrl: './app.html',
})
export class AppComponent {}