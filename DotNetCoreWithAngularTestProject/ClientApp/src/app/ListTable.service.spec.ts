/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ListTableService } from './ListTable.service';

describe('Service: ListTable', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ListTableService]
    });
  });

  it('should ...', inject([ListTableService], (service: ListTableService) => {
    expect(service).toBeTruthy();
  }));
});
