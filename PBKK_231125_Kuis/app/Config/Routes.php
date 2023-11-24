<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/admin/analitik', 'admin\Overview::analitik');

$routes->get('/', 'Home::index');
$routes->get('/Page/about', 'Page::about');
$routes->get('/Page/contact', 'Page::contact');
$routes->get('/admin', 'admin\Overview::index');