import { Component, ViewChild } from "@angular/core";
import { ProfilePage } from "../profile/profile";
import { NavController, Tabs, IonicPage } from "ionic-angular";
import { HomePage } from "../home/home";
import { PlanPage } from "../plan/plan";
import { FriendsPage } from "../friends/friends";

// @IonicPage()
@Component({
    selector: 'page-tabs',
    templateUrl: 'tabs.html'
})
export class TabsPage {

    @ViewChild('myTabs') tabs: Tabs;

    tab1Root = HomePage;
    tab2Root = ProfilePage;
    tab3Root = PlanPage;
    tab4Root = FriendsPage;

    constructor(private navCtrl: NavController) {
    }

}
