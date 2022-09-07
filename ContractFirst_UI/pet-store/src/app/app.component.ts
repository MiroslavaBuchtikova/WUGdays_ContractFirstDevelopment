import {Component, OnInit} from '@angular/core';
import {Observable} from "rxjs";
// import {Pet, PetsService} from "./api";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'pet-store';
  // pets: Observable<Pet[]>;

  // constructor(public PetService: PetsService) {
  //
  // }

  ngOnInit() {
    // this.pets = this.PetService.listPets(2);
  }
}
