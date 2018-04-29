import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { User } from '../../app/core/models/user-model';

@IonicPage()
@Component({
  selector: 'page-profile',
  templateUrl: 'profile.html',
})
export class ProfilePage {

  pageTitle: string;
  user: User;

  constructor(private navCtrl: NavController, private navParams: NavParams) {
    // this.user = this.navParams.get...
  }

  ionViewDidLoad() {
    this.pageTitle = 'Profile';
  }

}
