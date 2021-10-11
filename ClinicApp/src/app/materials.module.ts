import { NgModule } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatSelectModule} from '@angular/material/select';
import {MatDialogModule} from '@angular/material/dialog';

const modules = [
  MatToolbarModule,
  MatButtonModule,
  MatInputModule,
  MatGridListModule,
  MatFormFieldModule,
  MatSelectModule,
  MatDialogModule,
];

@NgModule({
  imports: [...modules],
  exports: [...modules],
})
export default class MaterialModule {}
