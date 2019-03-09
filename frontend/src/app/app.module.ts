import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { QuestionComponent } from './question/question.component';




import {MatButtonModule, MatCheckboxModule, MatInputModule, MatCardModule} from '@angular/material';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ApiService } from './shared/api.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [
    MatButtonModule, MatCheckboxModule, MatInputModule, MatCardModule
  ],
  exports: [
    MatButtonModule, MatCheckboxModule, MatInputModule, MatCardModule
  ],
})
export class AngularMaterialModule { }




@NgModule({
  declarations: [
    AppComponent,
    QuestionComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AngularMaterialModule
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
