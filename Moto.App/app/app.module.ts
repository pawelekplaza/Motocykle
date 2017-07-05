import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { NavbarComponent } from './Navbar/navbar.component';
import { HomeComponent } from './Home/home.component';
import { MotoService } from './Services/moto.service';
import { MotoListComponent } from './MotoList/moto-list.component';

@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        RouterModule.forRoot([
            { path: 'home', component: HomeComponent },
            { path: 'list', component: MotoListComponent },
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: '**', redirectTo: 'home', pathMatch: 'full' }],
            { useHash: true })
    ],
  declarations: [
      AppComponent,
      NavbarComponent,
      HomeComponent,
      MotoListComponent
    ],
  providers: [
      MotoService
    ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
