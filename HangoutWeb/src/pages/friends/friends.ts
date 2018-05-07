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

  pageTitle = "Connect";
  isFollowing: false;
  users: any[];
  friends: any[];

  constructor(public navCtrl: NavController, public navParams: NavParams,
    private userService: UserProvider) {
  }

  ionViewDidLoad() { // Only called first time page is rendered
    this.getUsers();
  }

  getUsers(): void {
    this.userService.getUsers().subscribe(result => {
      this.users = result.map(user => {
        return {
          username: user.username,
          firstName: user.firstName,
          lastName: user.lastName,
          following: false
        }
      })
    })
  }

  followUser(user: any): void {
    // Should update friends list
    user.following = !user.following;
  }


  getFollowStatus(user: any): string {
    if (user.following)
      return 'Following';
    else return 'Follow';
  }

  ionViewCanLeave() {
    //send request to userService to update friends list
  }


}
