import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { LoginPage } from '../pages/login/login';
import { LoginPageModule } from '../pages/login/login.module';
import { TabsPage } from '../pages/tabs/tabs';
import { ProfilePage } from '../pages/profile/profile';
import { ConfigProvider } from './core/services/config.provider';
import { UserProvider } from './core/services/user.provider';
import { AuthProvider } from './core/services/auth.provider';
import { PlanPage } from '../pages/plan/plan';
import { SignupPage } from '../pages/signup/signup';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { FriendsPage } from '../pages/friends/friends';

@NgModule({
  declarations: [
    MyApp,
    HomePage,
    LoginPage,
    ProfilePage,
    PlanPage,
    SignupPage,
    FriendsPage,
    TabsPage
  ],
  imports: [
    BrowserModule,
    CommonModule,
    HttpClientModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    LoginPage,
    ProfilePage,
    PlanPage,
    SignupPage,
    FriendsPage,
    TabsPage
  ],
  providers: [
    ConfigProvider,
    UserProvider,
    AuthProvider,
    StatusBar,
    SplashScreen,
    { provide: ErrorHandler, useClass: IonicErrorHandler }
  ]
})
export class AppModule { }
