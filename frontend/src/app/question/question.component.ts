import { Component, OnInit } from '@angular/core';
import { ApiService } from '../shared/api.service';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent implements OnInit {

  model = {};

  constructor(private apiService: ApiService) { }

  ngOnInit() {
  }


  post(){
    this.apiService.postQuestion(this.model);
  }

}
