import { Component, OnInit, Input  } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-custom-text',
  templateUrl: './custom-text.component.html',
  styleUrls: ['./custom-text.component.css']
})
export class CustomTextComponent implements OnInit {
  @Input('prefix') prefix: string;
  @Input('suffix') suffix: string;
  @Input('placeholder') placeholder: string;
  @Input('hint') hint: string;
  @Input('errorMessage') errorMessage: string;
  @Input('formGroup') formGroup: FormGroup;

  constructor() { }

  ngOnInit() {
    if (!this.formGroup){
      this.formGroup = new FormGroup({
        'validator': new FormControl('', [ ]),
      });
    }
    this.formGroup.valueChanges.subscribe(value => {
      console.log('name has changed:', value)
    });
  }

  get validate() { return this.formGroup.get('validator'); }

}
