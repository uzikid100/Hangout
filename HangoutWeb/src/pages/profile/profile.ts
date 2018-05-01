import { Component, ViewChild, ChangeDetectorRef, ChangeDetectionStrategy } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { User } from '../../app/core/models/user-model';
import { UserProvider } from '../../app/core/services/user.provider';
import { MockUser } from '../../app/core/mocks/mock-user';

@IonicPage()
@Component({
  selector: 'page-profile',
  templateUrl: 'profile.html',
})
export class ProfilePage {

  pageTitle: string;
  user: User = MockUser;

  constructor(private navCtrl: NavController, private navParams: NavParams,
    private userService: UserProvider, private ref: ChangeDetectorRef) {
    this.userService.getUser('kdub911').subscribe(user => {
      this.user = user;
      console.log(this.user);
    })
  }

  ionViewWillEnter() {
    console.log('Page Loaded!!!');
    this.pageTitle = 'Profile';
    console.log(this.user);
  }


  ionViewDidLoad() {

  }

}
