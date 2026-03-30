import { Controller, Get } from '@nestjs/common';
import { AppService } from './app.service';

@Controller()
export class AppController {
  constructor(private readonly appService: AppService) {}

  @Get('health')
  getHealth() {
    return { status: 'ok', service: 'NestJS API' };
  }

  @Get('api/hello')
  getHello() {
    return this.appService.getHello();
  }

  @Get('api/todos')
  getTodos() {
    return this.appService.getTodos();
  }
}
