import { NgModule } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';

const modules = [
  MatToolbarModule,
  MatButtonModule,
  MatInputModule
];

@NgModule({
  imports: [...modules],
  exports: [...modules],
})
export default class MaterialModule {}
