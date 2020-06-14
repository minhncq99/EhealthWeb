import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit, Inject } from '@angular/core';
declare var $:any;

@Component({
  selector: 'app-disease-catalog',
  templateUrl: './disease-catalog.component.html',
  styleUrls: ['./disease-catalog.component.css']
})
export class DiseaseCatalogComponent implements OnInit {
  private title:string = 'Danh mục bệnh';
  private isShowChapter:boolean = true;
  private isShowGroup:boolean = false;
  private isShowNumber:boolean = false;
  private isShowDiseases:boolean = false;
  private isEdit:boolean = true;
  public res: any;
  public listChapter: [];
  public listGroup: [];
  public listSTT: [];
  public listDisease: [];
  public listDiseaseWatched:any = [];

  public chapter:any={
    chapterId : 0,
    name : ""
  }
  public group:any={
    groupId : 0,
    name : "",
    chapterId : 0
  }
  public number:any={
    numberId : 0,
    name : "",
    groupId : 0
  }
  public disease:any={
    diseaseId : 0,
    englishName : "",
    vietnameseName :"",
    symptom :"",
    numberId : 0
  }


  constructor( private http: HttpClient, @Inject('BASE_URL') baseurl: string ) {
    this.loadListChapter();
    this.loadListGroup();
    this.loadListNumber();
    this.loadListDisease();
  }

  ngOnInit() {
    this.listDiseaseWatched = JSON.parse(sessionStorage.getItem('$watched'));
  }

  loadListChapter(){
    this.http.get("https://localhost:44381/" + "api/Chapters/get-all").subscribe(result =>{
      this.res = result;
      this.listChapter = this.res.data;
    }, error => console.error(error));
  }

  loadListGroup(){
    this.http.get("https://localhost:44381/" + "api/Groups/get-all").subscribe(result =>{
      this.res = result;
      this.listGroup = this.res.data;
    }, error => console.error(error));
  }

  loadListNumber(){
    this.http.get("https://localhost:44381/" + "api/Numbers/get-all").subscribe(result =>{
      this.res = result;
      this.listSTT = this.res.data;
    }, error => console.error(error));
  }

  loadListDisease(){
    this.http.get("https://localhost:44381/" + "api/Diseases/get-all").subscribe(result =>{
      this.res = result;
      this.listDisease = this.res.data;
    }, error => console.error(error));
  }

  

  showBodyChapter(){
    if(this.isShowChapter == false){
      this.isShowChapter = true;
      this.isShowGroup = false;
      this.isShowNumber = false;
      this.isShowDiseases = false;
      this.loadListChapter();
    }
  }
  showBodyGroup(){
    if(this.isShowGroup == false){
      this.isShowChapter = false;
      this.isShowGroup = true;
      this.isShowNumber = false;
      this.isShowDiseases = false;
      this.loadListGroup();
    }
  }
  showBodyNumber(){
    if(this.isShowNumber == false){
      this.isShowChapter = false;
      this.isShowGroup = false;
      this.isShowNumber = true;
      this.isShowDiseases = false;
      this.loadListNumber();
    }
  }
  showBodyDiseases(){
    if(this.isShowDiseases == false){
      this.isShowChapter = false;
      this.isShowGroup = false;
      this.isShowNumber = false;
      this.isShowDiseases = true;
      this.loadListDisease();
    }
  } 
  
  public styleMenuHide = {
    color: "black",
    backgroundColor: "#E7E7E7"
  }
  public styleMenuShow = {
    color: "white",
    backgroundColor: "#1576C4"
  }

  openModalChapter(isNew, index){
    if(isNew){
      this.isEdit = false;
      this.chapter ={
        chapterId : 0,
        name : ""
      }
    }else{
      this.isEdit = true;
      this.chapter = index;
    }
    $('#chapterModal').modal("show");
  }

  openModalGroup(isNew, index){
    if(isNew){
      this.isEdit = false;
      this.group ={
        groupId : 0,
        name : "",
        chapterId : 0
      }
    }else{
      this.isEdit = true;
      this.group = index;
    }
    $('#groupModal').modal("show");
  }

  openModalNumber(isNew, index){
    if(isNew){
      this.isEdit = false;
      this.number ={
        numberId : 0,
        name : "",
        groupId : 0
      }
    }else{
      this.isEdit = true;
      this.number = index;
    }
    $('#numberModal').modal("show");
  }

  openModalDisease(isNew, index){
    if(isNew){
      this.isEdit = false;
      this.disease ={
        diseaseId : 0,
        englishName : "",
        vietnameseName :"",
        symptom :"",
        numberId : 0
      }
    }else{
      this.isEdit = true;
      this.disease = index;
    }
    $('#diseaseModal').modal("show");
  }

  addChapter(){
    if(this.chapter.name == ""){
      alert('Chapter Name not null!!!')
    }else{
      var x = this.chapter;
      this.http.post("https://localhost:44381/" + "api/Chapters/create", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.chapter = res.data;
          this.isEdit = false;
          alert('Đã thêm thành công');
          location.reload();
        }
      }, error => console.error(error));
    }
  }

  addGroup(){
    if(this.group.name == "" || this.group.chapterId == ""){
      alert('Data have values null!!!')
    }else{
      this.group.chapterId = parseInt(this.group.chapterId);
      var x = this.group;
      this.http.post("https://localhost:44381/" + "api/Groups/create", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.group = res.data;
          this.isEdit = true;
          alert('Đã thêm thành công');
          location.reload();
        }
      }, error => console.error(error));
    }
  }

  addNumber(){
    if(this.number.name == "" || this.number.groupId == ""){
      alert('Data have values null!!!')
    }else{
      this.number.groupId = parseInt(this.number.groupId);
      var x = this.number;
      this.http.post("https://localhost:44381/" + "api/Numbers/create", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.number = res.data;
          this.isEdit = true;
          alert('Đã thêm thành công');
          location.reload();
        }
     }, error => console.error(error));
    }
  }

  addDisease(){
    if(this.disease.vietnameseName == "" || this.disease.englishName == "" || this.disease.symptom == "" || this.disease.numberId == ""){
      alert('Data have values null!!!')
    }else{
      this.disease.numberId = parseInt(this.disease.numberId);
      var x = this.disease;
      this.http.post("https://localhost:44381/" + "api/Diseases/create", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.disease = res.data;
          this.isEdit = true;
          alert('Đã thêm thành công');
          location.reload();
        }
      }, error => console.error(error));
    }
  }

  updateChapter(){
    if(this.chapter.name == ""){
      alert('Chapter Name not null!!!')
      this.loadListChapter();
    }else{
      var x = this.chapter;
      this.http.put("https://localhost:44381/" + "api/Chapters/update", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.chapter = res.data;
          this.isEdit = false;
          alert('Đã lưu thành công');
          location.reload();
        }
      }, error => console.error(error));
    }
  }

  updateGroup(){
    if(this.group.name == ""){
      alert('Group Name not null!!!')
      this.loadListGroup();
    }else{
      this.group.chapterId = parseInt(this.group.chapterId);
      var x = this.group;
      this.http.put("https://localhost:44381/" + "api/Groups/update", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.group = res.data;
          alert('Đã lưu thành công');
          location.reload();
        }
      }, error => console.error(error));
    }
  }

  updateDisease(){
    if(this.disease.englishName == "" || this.disease.vietnameseName == "" || this.disease.symptom == "" ){
      alert('Data have values null!!!')
      this.loadListDisease();
    }else{
      this.disease.numberId = parseInt(this.disease.numberId);
      var x = this.disease;
      this.http.put("https://localhost:44381/" + "api/Diseases/update", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.disease = res.data;
          alert('Đã lưu thành công');
          location.reload();
        }
      }, error => console.error(error));
    }
  }

  updateNumber(){
    if(this.number.name == ""){
      alert('Number Name not null!!!')
      this.loadListNumber();
    }else{
      this.number.groupId = parseInt(this.number.groupId);
      var x = this.number;
      this.http.put("https://localhost:44381/" + "api/Numbers/update", x).subscribe(result =>{
        var res:any = result;
        if(res.success){
          this.number = res.data;
          alert('Đã lưu thành công');
          location.reload();
        }
      }, error => console.error(error));
    }
  }

  deleteChapter(index){
    if(confirm('Bạn có chắc chắn xóa nó không?')){
      this.chapter = index;
      var x = this.chapter;
      const httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' }), body: x
      };
      this.http.delete("https://localhost:44381/" + "api/Chapters/delete", httpOptions).subscribe(result =>{
      var res:any = result;
      if(res.success){
        alert('Đã xóa thành công');
        this.loadListChapter();
      }
    }, error => console.error(error));
    }
  }

  deleteGroup(index){
    if(confirm('Bạn có chắc chắn xóa nó không?')){
      this.group = index;
      var x = {
        id : this.group.groupId,
        keyword : this.group.name
      }
      const httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' }), body: x
      };
      this.http.delete("https://localhost:44381/" + "api/Groups/delete-group", httpOptions).subscribe(result =>{
      var res:any = result;
      if(res.success){
        alert('Đã xóa thành công');
        this.loadListGroup();
      }
    }, error => console.error(error));
    }
  }

  deleteNumber(index){
    if(confirm('Bạn có chắc chắn xóa nó không?')){
      this.number = index;
      var x = {
        id : this.number.numberId,
        keyword : this.number.name
      }
      const httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' }), body: x
      };
      this.http.delete("https://localhost:44381/" + "api/Numbers/delete", httpOptions).subscribe(result =>{
      var res:any = result;
      if(res.success){
        alert('Đã xóa thành công');
        this.loadListNumber();
      }
    }, error => console.error(error));
    }
  }

  deleteDisease(index){
    if(confirm('Bạn có chắc chắn xóa nó không?')){
      this.disease = index;
      var x = {
        id : this.disease.diseaseId,
        keyword : this.disease.vietnameseName
      }
      const httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' }), body: x
      };
      this.http.delete("https://localhost:44381/" + "api/Diseases/delete", httpOptions).subscribe(result =>{
      var res:any = result;
      if(res.success){
        alert('Đã xóa thành công');
        this.loadListDisease();
      }
    }, error => console.error(error));
    }
  }

  saveDiseaseWatched(index){
    this.listDiseaseWatched.push(index);
    sessionStorage.setItem('$watched', JSON.stringify(this.listDiseaseWatched));
  }

  saveChapterData(index){
    sessionStorage.setItem('$dataChapter', JSON.stringify(index));
  }
  saveGroupData(index){
    sessionStorage.setItem('$dataGroup', JSON.stringify(index));
  }
  saveNumberData(index){
    sessionStorage.setItem('$dataNumber', JSON.stringify(index));
  }
}

