import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sample',
  templateUrl: './sample.component.html',
  styleUrls: ['./sample.component.css']
})
export class SampleComponent implements OnInit {
  
  title = "Property Binding";      
  
  imgUrl="https://www.hdwallpaper.nu/wp-content/uploads/2015/06/1843513.jpg";   
  constructor() { }

  ngOnInit(): void {
  }
  onSave($event){    
    console.log("Save button is clicked!", $event);    
}
}