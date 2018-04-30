import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, App } from 'ionic-angular';
import { UserProvider } from '../../app/core/services/user.provider';
import { TabsPage } from '../tabs/tabs';


@IonicPage()
@Component({
  selector: 'page-signup',
  templateUrl: 'signup.html',
})
export class SignupPage {

  appTitle: string = 'PLANiT';
  username: string = '';
  password: string = '';
  constructor(public navCtrl: NavController, public navParams: NavParams,
    private userService: UserProvider) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad SignupPage');
  }

  loginUser() {
    if (this.username.length > 0 && this.password.length > 0)
      this.navCtrl.push(TabsPage);
  }
}
