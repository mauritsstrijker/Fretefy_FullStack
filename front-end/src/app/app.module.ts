import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { APP_INITIALIZER, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ToolbarModule } from './components/toolbar/toolbar.module';
import { HomeModule } from './modules/home/home.module';
import { LoginModule } from './modules/login/login.module';
import { AuthInterceptor } from './shared/auth/auth.interceptor';
import { AuthService } from './shared/auth/auth.service';
import { ToastModule } from './shared/toast/toast.module';

export function initAuth(authService: AuthService) {
  return () => authService.me().toPromise().catch(() => {});
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule,
    
    HomeModule,
    LoginModule,
    ToolbarModule,
    ToastModule,

    AppRoutingModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    },
    {
      provide: APP_INITIALIZER,
      useFactory: initAuth,
      deps: [AuthService],
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
