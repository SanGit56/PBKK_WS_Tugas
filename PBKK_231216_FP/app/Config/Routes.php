<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/', 'Home::index');
$routes->get('/login', 'Login::index');
$routes->get('/login/proses', 'Login::proses');
$routes->post('/login/masuk', 'Login::masuk');
$routes->get('/login/keluar', 'Login::keluar');