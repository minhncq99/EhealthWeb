import { NumberDetailComponent } from './number-detail/number-detail.component';
import { GroupDetailComponent } from './group-detail/group-detail.component';
import { ChapterDetailComponent } from './chapter-detail/chapter-detail.component';
import { DiseasesRecentComponent } from './diseases-recent/diseases-recent.component';
import { DiseaseCatalogComponent } from './disease-catalog/disease-catalog.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Routes,RouterModule } from '@angular/router';
import { NgbDropdown} from '@ng-bootstrap/ng-bootstrap';
import {  GoogleChartsModule } from 'angular-google-charts';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { FormComponent } from './form/form.componet';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { DropdownComponent } from './dropdown/dropdown.component'; 
import { AccountComponent } from './account/account.component';
import { SigninComponent } from './signin/signin.component';
import { CreateAccountComponent } from './create-account/create-account.component';
import { CookieService } from "ngx-cookie-service";
import { DiseasesSaveComponent } from './diseases-save/diseases-save.component';
import { BannerComponent } from './banner/banner.component';
import { SearchComponent } from './search/search.component';
import { IDiseaseComponent } from './i-disease/i-disease.component';
import { FooterComponent } from './footer/footer.component';
import { AddAdminAccountComponent } from './add-admin-account/add-admin-account.componet'
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    FormComponent,
    DropdownComponent,
    AccountComponent,
    SigninComponent,
    CreateAccountComponent,
    DiseasesSaveComponent,
    BannerComponent,
    SearchComponent,
    IDiseaseComponent,
    FooterComponent,
    DiseasesSaveComponent,
    DiseaseCatalogComponent,
    DiseasesRecentComponent,
    ChapterDetailComponent,
    GroupDetailComponent,
    NumberDetailComponent,
    AddAdminAccountComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    GoogleChartsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'form', component: FormComponent },
      { path: 'account', component: AccountComponent },
      { path: 'signin', component: SigninComponent },
      { path: 'create-account', component: CreateAccountComponent },
      { path: 'diseases-save', component: DiseasesSaveComponent },

      { path: 'banner', component: BannerComponent },
      { path: 'search', component: SearchComponent },
      { path: 'i-disease', component: IDiseaseComponent },
      { path: 'footer', component: FooterComponent },

      { path: 'disease-catalog', component: DiseaseCatalogComponent },
      { path: 'diseases-recent', component: DiseasesRecentComponent },
      { path: 'chapter-detail', component: ChapterDetailComponent },
      { path: 'group-detail', component: GroupDetailComponent },
      { path: 'number-detail', component: NumberDetailComponent },
      { path: 'add-admin-account', component: AddAdminAccountComponent },

    ]),
    NgbModule.forRoot()
  ],
  providers: [CookieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
