import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { LoginPage } from '../login/login';

// @IonicPage
@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  public loginPage: any = LoginPage;
  constructor(public navCtrl: NavController) {

  }

}
