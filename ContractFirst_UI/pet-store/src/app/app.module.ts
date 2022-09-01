import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {ApiModule, Configuration, ConfigurationParameters} from "./api";
import {HttpClientModule} from "@angular/common/http";
import {CommonModule} from "@angular/common";

export function apiConfigFactory (): Configuration {
  const params: ConfigurationParameters = {
   basePath: "https://b163db33-ee4b-4774-adca-3c8a37fd90ee.mock.pstmn.io"
  }
  return new Configuration(params);
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    HttpClientModule,
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    ApiModule.forRoot(apiConfigFactory)
  ],
  providers: [
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
