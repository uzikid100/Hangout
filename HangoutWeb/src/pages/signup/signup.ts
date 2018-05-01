import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, App } from 'ionic-angular';
import { UserProvider } from '../../app/core/services/user.provider';
import { TabsPage } from '../tabs/tabs';
import { User } from '../../app/core/models/user-model';
import { MockUser } from '../../app/core/mocks/mock-user';


@IonicPage()
@Component({
  selector: 'page-signup',
  templateUrl: 'signup.html',
})
export class SignupPage {

  appTitle: string = 'PLANiT';
  username: string = '';
  password: string = '';
  user: User;

  constructor(public navCtrl: NavController, public navParams: NavParams,
    private userService: UserProvider) {
  }

  ionViewDidLoad() {
  }


  loginAsNewUser() {
    // this.navCtrl.push(TabsPage, this.user);
  }

  createNewUser() {
    if (this.username.length > 0 && this.password.length > 0) {
      this.user = MockUser;

      this.userService.addNewUser(this.user).subscribe(result => {
        console.log('Result: ' + result);
        this.navCtrl.push(TabsPage);
      })
    }
  }
}
