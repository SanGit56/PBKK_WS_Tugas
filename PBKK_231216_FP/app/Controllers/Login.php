<?php

namespace App\Controllers;

use App\Controllers\BaseController;
use App\Models\UserModel;
use Google_Client;

class Login extends BaseController
{
    protected $googleClient;
    protected $users;

    public function __construct()
    {
        session();
        $this->users = new UserModel();
        $this->googleClient = new Google_Client();

        $this->googleClient->setClientId('998411666484-gd0up00bmoq0h28ukmdkgijnq5m76iq4.apps.googleusercontent.com');
        $this->googleClient->setClientSecret('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');
        $this->googleClient->setRedirectUri('http://localhost:8080/login/proses');
        $this->googleClient->addScope('email');
        $this->googleClient->addScope('profile');
    }

    public function index()
    {
        $data['link'] = $this->googleClient->createAuthUrl();

        return view('login/index', $data);
    }

    public function proses()
    {
        $token = $this->googleClient->fetchAccessTokenWithAuthCode($this->request->getVar('code'));

        if (!isset($token['error'])) {
            $this->googleClient->setAccessToken($token['access_token']);
            $googleService = new \Google_Service_Oauth2($this->googleClient);
            $data = $googleService->userinfo->get();

            $row = [
                'id_oauth' => $data["id"],
                'nama_pengguna' => $data["name"],
                'surel' => $data["email"]
            ];
            $this->users->save($row);

            session()->set($row);

            return view('login/berhasil');
        }
    }

    public function masuk()
    {
        $namapengguna = $this->request->getPost('napeng');
        $katasandi = $this->request->getPost('kasan');

        $pengguna = $this->users->where('nama_pengguna', $namapengguna)->first();

        if ($pengguna) {
            if ($katasandi == $pengguna->sandi) {
                $datapengguna = [
                    'nama_pengguna' => $namapengguna,
                    'masuk' => true,
                ];

                session()->set($datapengguna);

                return view('login/berhasil');
            } else {
                return view('login/gagal');
            }
        } else {
            $datapengguna = [
                'id_oauth' => rand(),
                'nama_pengguna' => $namapengguna,
                'sandi' => $katasandi,
                'surel' => $namapengguna . '@efsatu.com'
            ];
            $this->users->save($datapengguna);

            session()->set($datapengguna);

            return view('login/berhasil');
        }
    }

    public function keluar()
    {
        session_destroy();

        return redirect()->to('login');
    }
}
