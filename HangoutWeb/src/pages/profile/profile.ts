import { Component, ViewChild, ChangeDetectorRef, ChangeDetectionStrategy, ElementRef } from '@angular/core';
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
  }

  ionViewWillEnter() {// Called every time cached page is loaded
    console.log('ViewWilEnter!');
    this.pageTitle = 'Profile';
    console.log(this.user);
  }

  ionViewDidLoad() { // Only called first time page is rendered
    console.log('ViewDidLoad');
    console.log(this.user);
    this.getLoggedInUser();
  }

  getLoggedInUser(): void {
    this.userService.getLoggedInUser.subscribe(user => this.user = user);
  }
}
