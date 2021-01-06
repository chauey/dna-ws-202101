import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ShowService, ShowDto } from '@proxy/shows';

@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.scss'],
  providers: [ListService],
})
export class ShowComponent implements OnInit {
  show = { items: [], totalCount: 0 } as PagedResultDto<ShowDto>;

  constructor(public readonly list: ListService, private showService: ShowService) {}

  ngOnInit() {
    const showStreamCreator = (query) => this.showService.getList(query);

    this.list.hookToQuery(showStreamCreator).subscribe((response) => {
      this.show = response;
    });
  }
}
