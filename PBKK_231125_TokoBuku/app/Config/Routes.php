<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/', 'Home::index');
$routes->get('/coba', 'Home::coba');
$routes->get('/admin', 'admin\Overview::index');
$routes->get('/admin/analitik', 'admin\Overview::analitik');
$routes->get('/admin/buku', 'admin\Buku::index');