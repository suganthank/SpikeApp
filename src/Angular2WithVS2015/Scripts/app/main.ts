﻿/// <reference path="../../typings/globals/node/index.d.ts" />
/// <reference path="../../typings/globals/core-js/index.d.ts" />
// main entry point
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app.module';

platformBrowserDynamic().bootstrapModule(AppModule);
