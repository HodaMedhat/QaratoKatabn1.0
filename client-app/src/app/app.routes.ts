import { NgModule } from '@angular/core';
import { Routes } from '@angular/router';
import { CreateBook } from './books/create-book/create-book'; 

export const routes: Routes = [
{ path: 'books/create', component: CreateBook }
];

