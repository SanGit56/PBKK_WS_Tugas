<?php

namespace App\Controllers\admin;
use App\Controllers\BaseController;

class Overview extends BaseController
{
	public function index()
	{
        return view('admin/overview');
	}

	public function analitik()
	{
        return view('admin/analitik');
	}
}