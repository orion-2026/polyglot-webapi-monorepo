import { Injectable } from '@nestjs/common';

@Injectable()
export class AppService {
  getHello() {
    return {
      message: 'Hello from NestJS API',
      framework: 'NestJS',
      timestamp: new Date().toISOString(),
    };
  }

  getTodos() {
    return [
      { id: 1, title: 'Create polyglot sample', done: true },
      { id: 2, title: 'Compare framework styles', done: false },
      { id: 3, title: 'Push repo to GitHub', done: false },
    ];
  }
}
