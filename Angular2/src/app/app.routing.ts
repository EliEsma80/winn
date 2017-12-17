import {ModuleWithProviders} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';

import { UserComponent }  from './components/user.component';


const appRoutes: Routes =[
{
 path:'',
 component: UserComponent
}

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);