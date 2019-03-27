import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SmartShop';

  public value: string = "359884123321";
    public mask: string = "(999) 000-00-00-00";
}
