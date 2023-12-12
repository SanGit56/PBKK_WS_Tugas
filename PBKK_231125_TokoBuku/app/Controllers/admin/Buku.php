<?php

namespace App\Controllers\admin;
use App\Controllers\BaseController;

class Buku extends BaseController
{
	public function index()
	{
        return view('buku/baca');
	}
}