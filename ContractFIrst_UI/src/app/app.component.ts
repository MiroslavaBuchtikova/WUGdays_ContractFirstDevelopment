import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Pets } from './api/models';
import { PetsService } from './api/services';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  constructor(public PeService: PetsService){}
  title = 'ContractFirstApi';
  pets : Observable<Pets>
  ngOnInit() {
    this.pets = this.PeService.listPets({limit: 2});
  }
}
