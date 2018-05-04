import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { User } from '../../app/core/models/user-model';
import { UserProvider } from '../../app/core/services/user.provider';

@IonicPage()
@Component({
  selector: 'page-friends',
  templateUrl: 'friends.html',
})
export class FriendsPage {

  pageTitle = "Friends";
  users: User[];
  constructor(public navCtrl: NavController, public navParams: NavParams,
    private userService: UserProvider) {
  }

  ionViewDidLoad() { // Only called first time page is rendered
    this.getUsers();
  }

  getUsers(): void {
    this.userService.getUsers().subscribe(users =>
      this.users = users)
  }


}
