import { Component, ViewEncapsulation } from '@angular/core';
import { MyMonitoringService } from './services/monitoring.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class AppComponent {
  title = 'wedding-web-app';

  constructor(private myMoniotringService: MyMonitoringService) {
    console.error('Nie szukaj tutaj niczego :)');
   }
}