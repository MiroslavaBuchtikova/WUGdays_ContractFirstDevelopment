import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ApiConfiguration } from './api/api-configuration';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    HttpClientModule,
    CommonModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    {
      provide: ApiConfiguration,
      useValue:{
        rootUrl: "https://b163db33-ee4b-4774-adca-3c8a37fd90ee.mock.pstmn.io"
      }
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
