import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HomePage } from '../home/home';
import { TabsPage } from '../tabs/tabs';
import { ProfilePage } from '../profile/profile';
import { AuthProvider } from '../../app/core/services/auth.provider';
import { UserProvider } from '../../app/core/services/user.provider';
import { User } from '../../app/core/models/user-model';
import { SignupPage } from '../signup/signup';

@IonicPage()
@Component({
  selector: 'page-login',
  templateUrl: 'login.html',
})
export class LoginPage {

  public homePage: any = HomePage;
  public profilePage: any = ProfilePage;
  public signupPage: any = SignupPage;
  tabsPage = TabsPage;

  appTitle: string = 'PLANiT';
  private user: User;

  username: string = '';
  password: string = '';

  constructor(private navCtrl: NavController, private navParams: NavParams,
    private userService: UserProvider) {
  }

  ionViewDidLoad() {
  }

  tryLogin() {
    if (this.username.length > 0 && this.password.length > 0) {
      this.userService.logIn(this.username).subscribe(user => {
        if (user) {
          this.navCtrl.push(TabsPage);
        }
      });
    }

  }

  addFriendTest() {
    this.userService.addFriend(1, 5002);
  }

}
